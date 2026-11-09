# Fact 1dbdb6f6

Store id: 920bdf3d-c09f-4d1f-95ee-c84b3c57e4b3

## Text

```text
def resolve_expression_parameter(self, compiler, connection, sql, param)
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
- posted_at: `2026-11-09T22:39:43.6964960+00:00`

## Data

```json
{
  "end_line": 443,
  "entity_kind": "method",
  "parent": "JSONIn",
  "start_line": 404,
  "symbol": "JSONIn.resolve_expression_parameter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":404,"selector":"L404-L443","symbol":"JSONIn.resolve_expression_parameter"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONIn.resolve_expression_parameter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 443,
    "entity_kind": "method",
    "parent": "JSONIn",
    "start_line": 404,
    "symbol": "JSONIn.resolve_expression_parameter"
  },
  "id": "920bdf3d-c09f-4d1f-95ee-c84b3c57e4b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6964960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 404,
        "selector": "L404-L443",
        "symbol": "JSONIn.resolve_expression_parameter"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "c30c7ad2-e27c-40d3-b6ef-22ddb3412acf",
  "subject_name": "django/db/models/fields/json::JSONIn.resolve_expression_parameter",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression_parameter(self, compiler, connection, sql, param)"
}
```
