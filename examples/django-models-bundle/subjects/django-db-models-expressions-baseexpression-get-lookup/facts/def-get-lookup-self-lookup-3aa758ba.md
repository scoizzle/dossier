# Fact 3aa758ba

Store id: dcbed291-2f3f-40aa-b7c6-9e5423b5b51d

## Text

```text
def get_lookup(self, lookup)
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
- posted_at: `2026-11-09T22:39:41.5216300+00:00`

## Data

```json
{
  "end_line": 404,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 403,
  "symbol": "BaseExpression.get_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":403,"selector":"L403-L404","symbol":"BaseExpression.get_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 404,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 403,
    "symbol": "BaseExpression.get_lookup"
  },
  "id": "dcbed291-2f3f-40aa-b7c6-9e5423b5b51d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5216300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 403,
        "selector": "L403-L404",
        "symbol": "BaseExpression.get_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0b4bd458-15c7-4b4a-8731-959b9a2479f9",
  "subject_name": "django/db/models/expressions::BaseExpression.get_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lookup(self, lookup)"
}
```
