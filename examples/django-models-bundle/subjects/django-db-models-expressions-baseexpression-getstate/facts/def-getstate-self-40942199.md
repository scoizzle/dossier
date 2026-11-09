# Fact 40942199

Store id: 921307cd-713b-425a-b215-77446ae67795

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T23:44:49.2760080+00:00`

## Data

```json
{
  "end_line": 200,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 197,
  "symbol": "BaseExpression.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":197,"selector":"L197-L200","symbol":"BaseExpression.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 200,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 197,
    "symbol": "BaseExpression.__getstate__"
  },
  "id": "921307cd-713b-425a-b215-77446ae67795",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2760080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 197,
        "selector": "L197-L200",
        "symbol": "BaseExpression.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9c0a1ce9-b9f0-4332-8108-a63db7e240c0",
  "subject_name": "django/db/models/expressions::BaseExpression.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
