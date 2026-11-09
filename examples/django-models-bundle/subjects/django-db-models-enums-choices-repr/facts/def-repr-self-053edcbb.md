# Fact 053edcbb

Store id: 5497f934-523a-40f7-893f-322f96472589

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:49.0467910+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "method",
  "parent": "Choices",
  "start_line": 64,
  "symbol": "Choices.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L65","symbol":"Choices.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/enums::Choices.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "method",
    "parent": "Choices",
    "start_line": 64,
    "symbol": "Choices.__repr__"
  },
  "id": "5497f934-523a-40f7-893f-322f96472589",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.0467910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L65",
        "symbol": "Choices.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "76976184-abce-4756-a332-7444336de2ce",
  "subject_name": "django/db/models/enums::Choices.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
