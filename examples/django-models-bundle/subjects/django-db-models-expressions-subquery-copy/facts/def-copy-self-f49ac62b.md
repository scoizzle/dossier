# Fact f49ac62b

Store id: fc8ef418-9224-4f30-8c46-88a75fb40227

## Text

```text
def copy(self)
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
- posted_at: `2026-11-09T23:44:49.6409860+00:00`

## Data

```json
{
  "end_line": 1864,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1861,
  "symbol": "Subquery.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1861,"selector":"L1861-L1864","symbol":"Subquery.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1864,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1861,
    "symbol": "Subquery.copy"
  },
  "id": "fc8ef418-9224-4f30-8c46-88a75fb40227",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6409860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1861,
        "selector": "L1861-L1864",
        "symbol": "Subquery.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "63249cb3-c633-4976-ae2f-27f195bb29c4",
  "subject_name": "django/db/models/expressions::Subquery.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
