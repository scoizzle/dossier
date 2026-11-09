# Fact 81ce8758

Store id: 118d3426-65fc-4de6-9c92-46440ef149ee

## Text

```text
def get_placeholder_sql(self, value, compiler, connection)
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
- posted_at: `2026-11-09T23:44:50.2853960+00:00`

## Data

```json
{
  "end_line": 2784,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2783,
  "symbol": "BinaryField.get_placeholder_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2783,"selector":"L2783-L2784","symbol":"BinaryField.get_placeholder_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.get_placeholder_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2784,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2783,
    "symbol": "BinaryField.get_placeholder_sql"
  },
  "id": "118d3426-65fc-4de6-9c92-46440ef149ee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2853960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2783,
        "selector": "L2783-L2784",
        "symbol": "BinaryField.get_placeholder_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f5fb9001-5571-4399-bb1f-2c15c6c2d30b",
  "subject_name": "django/db/models/fields/__init__::BinaryField.get_placeholder_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_placeholder_sql(self, value, compiler, connection)"
}
```
