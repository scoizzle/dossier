# Fact 1dbdb6f6

Store id: 616063e9-1946-4178-9ec3-c6451de560fb

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
- posted_at: `2026-11-09T23:44:51.0114440+00:00`

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
  "id": "616063e9-1946-4178-9ec3-c6451de560fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0114440+00:00"
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
  "subject_id": "c4eb6955-d1ab-46a7-87a3-fa6e00544982",
  "subject_name": "django/db/models/fields/json::JSONIn.resolve_expression_parameter",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression_parameter(self, compiler, connection, sql, param)"
}
```
