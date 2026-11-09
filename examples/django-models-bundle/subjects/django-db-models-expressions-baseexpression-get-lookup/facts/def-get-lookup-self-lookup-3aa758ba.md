# Fact 3aa758ba

Store id: 921a373c-7474-4523-9927-9687b248c98a

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
- posted_at: `2026-11-09T23:44:49.3425260+00:00`

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
  "id": "921a373c-7474-4523-9927-9687b248c98a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3425260+00:00"
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
  "subject_id": "cd4acef9-8a94-4ee3-9aea-221e86298385",
  "subject_name": "django/db/models/expressions::BaseExpression.get_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lookup(self, lookup)"
}
```
