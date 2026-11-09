# Fact a44e85d5

Store id: b8a51f54-6148-4107-a8e5-d2970d6a30de

## Text

```text
def generated_sql(self, connection)
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
- posted_at: `2026-11-09T23:44:50.8043160+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 54,
  "symbol": "GeneratedField.generated_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":54,"selector":"L54-L67","symbol":"GeneratedField.generated_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.generated_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 54,
    "symbol": "GeneratedField.generated_sql"
  },
  "id": "b8a51f54-6148-4107-a8e5-d2970d6a30de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.8043160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 54,
        "selector": "L54-L67",
        "symbol": "GeneratedField.generated_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "c87621b8-6f68-443d-a52c-7a61a3a409be",
  "subject_name": "django/db/models/fields/generated::GeneratedField.generated_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def generated_sql(self, connection)"
}
```
