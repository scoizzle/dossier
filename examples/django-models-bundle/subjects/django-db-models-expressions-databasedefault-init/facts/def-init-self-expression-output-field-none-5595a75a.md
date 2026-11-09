# Fact 5595a75a

Store id: b738b2f9-6930-487b-a6bc-8a2257aa4503

## Text

```text
def __init__(self, expression, output_field=None)
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
- posted_at: `2026-11-09T23:31:55.8803090+00:00`

## Data

```json
{
  "end_line": 1319,
  "entity_kind": "method",
  "parent": "DatabaseDefault",
  "start_line": 1317,
  "symbol": "DatabaseDefault.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1317,"selector":"L1317-L1319","symbol":"DatabaseDefault.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1319,
    "entity_kind": "method",
    "parent": "DatabaseDefault",
    "start_line": 1317,
    "symbol": "DatabaseDefault.__init__"
  },
  "id": "b738b2f9-6930-487b-a6bc-8a2257aa4503",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8803090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1317,
        "selector": "L1317-L1319",
        "symbol": "DatabaseDefault.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c6011ba5-9b96-4eb2-ab87-da2ad2cd9043",
  "subject_name": "django/db/models/expressions::DatabaseDefault.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, output_field=None)"
}
```
