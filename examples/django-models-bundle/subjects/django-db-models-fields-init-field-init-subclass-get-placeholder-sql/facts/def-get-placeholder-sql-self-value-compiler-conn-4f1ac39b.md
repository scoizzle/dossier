# Fact 4f1ac39b

Store id: 921330f8-8fdd-4d47-8c33-53197672a0c8

## Text

```text
def get_placeholder_sql(self, value, compiler, connection)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.9601750+00:00`

## Data

```json
{
  "end_line": 214,
  "entity_kind": "function",
  "parent": "Field.__init_subclass__",
  "start_line": 209,
  "symbol": "Field.__init_subclass__.get_placeholder_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":209,"selector":"L209-L214","symbol":"Field.__init_subclass__.get_placeholder_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__init_subclass__.get_placeholder_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 214,
    "entity_kind": "function",
    "parent": "Field.__init_subclass__",
    "start_line": 209,
    "symbol": "Field.__init_subclass__.get_placeholder_sql"
  },
  "id": "921330f8-8fdd-4d47-8c33-53197672a0c8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9601750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 209,
        "selector": "L209-L214",
        "symbol": "Field.__init_subclass__.get_placeholder_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "89a47622-8d94-458a-b8c4-5cb06b2cbbed",
  "subject_name": "django/db/models/fields/__init__::Field.__init_subclass__.get_placeholder_sql",
  "tags": [
    "entity:function"
  ],
  "text": "def get_placeholder_sql(self, value, compiler, connection)"
}
```
