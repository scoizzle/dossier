# Fact 186df9b8

Store id: 4cfc4dbb-8286-476c-985a-e9ef945b5d98

## Text

```text
def _validate_values_are_expressions(values, method_name)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:static_method`, `decorator:staticmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.1815250+00:00`

## Data

```json
{
  "end_line": 2358,
  "entity_kind": "static_method",
  "parent": "QuerySet",
  "start_line": 2346,
  "symbol": "QuerySet._validate_values_are_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2346,"selector":"L2346-L2358","symbol":"QuerySet._validate_values_are_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._validate_values_are_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2358,
    "entity_kind": "static_method",
    "parent": "QuerySet",
    "start_line": 2346,
    "symbol": "QuerySet._validate_values_are_expressions"
  },
  "id": "4cfc4dbb-8286-476c-985a-e9ef945b5d98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1815250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2346,
        "selector": "L2346-L2358",
        "symbol": "QuerySet._validate_values_are_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e2c0a679-020b-4669-bf38-e84e453b4dc3",
  "subject_name": "django/db/models/query::QuerySet._validate_values_are_expressions",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _validate_values_are_expressions(values, method_name)"
}
```
