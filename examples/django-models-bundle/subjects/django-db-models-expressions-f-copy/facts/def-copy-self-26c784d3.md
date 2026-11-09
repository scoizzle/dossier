# Fact 26c784d3

Store id: d3e67e23-5d13-4783-a543-3ec21bbbcec4

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
- posted_at: `2026-11-09T23:31:55.8398620+00:00`

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
  "id": "d3e67e23-5d13-4783-a543-3ec21bbbcec4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8398620+00:00"
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
  "subject_id": "6e44b83b-7b87-4bee-b8ee-f126b5fc2aa8",
  "subject_name": "django/db/models/expressions::F.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
