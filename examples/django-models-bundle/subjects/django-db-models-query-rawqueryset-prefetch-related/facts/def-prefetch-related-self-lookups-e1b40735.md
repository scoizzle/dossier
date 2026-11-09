# Fact e1b40735

Store id: 2e16e1f2-24f0-4fad-8427-d5702d57b88a

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
- posted_at: `2026-11-09T22:39:49.7771840+00:00`

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
  "id": "2e16e1f2-24f0-4fad-8427-d5702d57b88a",
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
    "posted_at": "2026-11-09T22:39:49.7771840+00:00"
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
  "subject_id": "00706050-5d77-4a8b-a0a7-394a77ec636b",
  "subject_name": "django/db/models/query::RawQuerySet.prefetch_related",
  "tags": [
    "entity:method"
  ],
  "text": "def prefetch_related(self, *lookups)"
}
```
