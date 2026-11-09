# Fact 56192506

Store id: 6202bb1c-944d-4f32-ab67-592bd14509bb

## Text

```text
def intersection(self, *other_qs)
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
- posted_at: `2026-11-09T22:39:49.6318370+00:00`

## Data

```json
{
  "end_line": 1780,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1773,
  "symbol": "QuerySet.intersection"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1773,"selector":"L1773-L1780","symbol":"QuerySet.intersection"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.intersection](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1780,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1773,
    "symbol": "QuerySet.intersection"
  },
  "id": "6202bb1c-944d-4f32-ab67-592bd14509bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6318370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1773,
        "selector": "L1773-L1780",
        "symbol": "QuerySet.intersection"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5830e142-614f-4ecf-8449-5768d4a54799",
  "subject_name": "django/db/models/query::QuerySet.intersection",
  "tags": [
    "entity:method"
  ],
  "text": "def intersection(self, *other_qs)"
}
```
