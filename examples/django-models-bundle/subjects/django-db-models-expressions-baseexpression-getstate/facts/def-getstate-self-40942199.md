# Fact 40942199

Store id: eb09d080-1d7c-4f62-aa98-f580f9aad401

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
- posted_at: `2026-11-09T22:39:41.5011720+00:00`

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
  "id": "eb09d080-1d7c-4f62-aa98-f580f9aad401",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5011720+00:00"
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
  "subject_id": "84994c6d-27c4-4be9-b2e4-bfc74e429698",
  "subject_name": "django/db/models/expressions::BaseExpression.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
