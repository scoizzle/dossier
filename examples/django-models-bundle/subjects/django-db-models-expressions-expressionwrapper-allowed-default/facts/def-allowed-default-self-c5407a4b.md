# Fact c5407a4b

Store id: edcd8d56-af4a-4dd6-94ec-daf9740dea9c

## Text

```text
def allowed_default(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.9388050+00:00`

## Data

```json
{
  "end_line": 1581,
  "entity_kind": "method",
  "parent": "ExpressionWrapper",
  "start_line": 1579,
  "symbol": "ExpressionWrapper.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1579,"selector":"L1579-L1581","symbol":"ExpressionWrapper.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1581,
    "entity_kind": "method",
    "parent": "ExpressionWrapper",
    "start_line": 1579,
    "symbol": "ExpressionWrapper.allowed_default"
  },
  "id": "edcd8d56-af4a-4dd6-94ec-daf9740dea9c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9388050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1579,
        "selector": "L1579-L1581",
        "symbol": "ExpressionWrapper.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "aa18e3ee-ee39-44a2-b415-5a2e54f751c5",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.allowed_default",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def allowed_default(self)"
}
```
