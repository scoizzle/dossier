# Fact d6534e54

Store id: 2a8f547b-e30e-4467-9b64-9f25ae56be19

## Text

```text
def select_related(self, *fields)
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
- posted_at: `2026-11-09T22:39:49.6415670+00:00`

## Data

```json
{
  "end_line": 1834,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1804,
  "symbol": "QuerySet.select_related"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1804,"selector":"L1804-L1834","symbol":"QuerySet.select_related"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance that will select related objects.",
    "locator": {
      "line": 1805
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.select_related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1834,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1804,
    "symbol": "QuerySet.select_related"
  },
  "id": "2a8f547b-e30e-4467-9b64-9f25ae56be19",
  "items": [
    {
      "locator": {
        "line": 1805
      },
      "text": "Return a new QuerySet instance that will select related objects."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6415670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1804,
        "selector": "L1804-L1834",
        "symbol": "QuerySet.select_related"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c1d15498-ab8e-439e-943b-037f866bab58",
  "subject_name": "django/db/models/query::QuerySet.select_related",
  "tags": [
    "entity:method"
  ],
  "text": "def select_related(self, *fields)"
}
```
