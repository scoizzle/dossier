# Fact e1b40735

Store id: c5ede9c0-c037-4c5d-9d62-34c6c55f4ad5

## Text

```text
def prefetch_related(self, *lookups)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.2215030+00:00`

## Data

```json
{
  "end_line": 2465,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2458,
  "symbol": "RawQuerySet.prefetch_related"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2458,"selector":"L2458-L2465","symbol":"RawQuerySet.prefetch_related"}`

## Items

```json
[
  {
    "text": "Same as QuerySet.prefetch_related()",
    "locator": {
      "line": 2459
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.prefetch_related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2465,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2458,
    "symbol": "RawQuerySet.prefetch_related"
  },
  "id": "c5ede9c0-c037-4c5d-9d62-34c6c55f4ad5",
  "items": [
    {
      "locator": {
        "line": 2459
      },
      "text": "Same as QuerySet.prefetch_related()"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2215030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2458,
        "selector": "L2458-L2465",
        "symbol": "RawQuerySet.prefetch_related"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8f7385b5-083d-46d1-a327-168665b6a37a",
  "subject_name": "django/db/models/query::RawQuerySet.prefetch_related",
  "tags": [
    "entity:method"
  ],
  "text": "def prefetch_related(self, *lookups)"
}
```
