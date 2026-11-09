# Fact 26c784d3

Store id: 160e0500-e18e-44cc-8569-7153fd5e466b

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
- posted_at: `2026-11-09T23:44:49.4887580+00:00`

## Data

```json
{
  "end_line": 943,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 942,
  "symbol": "F.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":942,"selector":"L942-L943","symbol":"F.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 943,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 942,
    "symbol": "F.copy"
  },
  "id": "160e0500-e18e-44cc-8569-7153fd5e466b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4887580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 942,
        "selector": "L942-L943",
        "symbol": "F.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2000bf89-dae1-47c4-ac9e-0ba3f2e0cd88",
  "subject_name": "django/db/models/expressions::F.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
