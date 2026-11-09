# Fact 1dbdb6f6

Store id: 47ad4d4e-cfff-4508-98c2-3f8892e9f33d

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
- posted_at: `2026-11-09T23:31:57.9486030+00:00`

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
  "id": "47ad4d4e-cfff-4508-98c2-3f8892e9f33d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9486030+00:00"
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
  "subject_id": "ef799cd3-f244-4718-aa5c-a19471966bc9",
  "subject_name": "django/db/models/fields/json::JSONIn.resolve_expression_parameter",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression_parameter(self, compiler, connection, sql, param)"
}
```
