# Fact 40942199

Store id: d5aae92a-abdc-4bb3-97cc-bd88241a4991

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
- posted_at: `2026-11-09T23:31:55.7589360+00:00`

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
  "id": "d5aae92a-abdc-4bb3-97cc-bd88241a4991",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7589360+00:00"
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
  "subject_id": "226f3499-f386-41cc-a0bd-bb0b00dfff72",
  "subject_name": "django/db/models/expressions::BaseExpression.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
