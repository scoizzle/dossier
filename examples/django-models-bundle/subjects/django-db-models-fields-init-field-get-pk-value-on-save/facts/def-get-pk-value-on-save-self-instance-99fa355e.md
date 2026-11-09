# Fact 99fa355e

Store id: 64b72797-1db4-4286-8461-779c938e4df2

## Text

```text
def get_pk_value_on_save(self, instance)
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
- posted_at: `2026-11-09T23:44:50.0018200+00:00`

## Data

```json
{
  "end_line": 796,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 787,
  "symbol": "Field.get_pk_value_on_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":787,"selector":"L787-L796","symbol":"Field.get_pk_value_on_save"}`

## Items

```json
[
  {
    "text": "Hook to generate new PK values on save. This method is called when saving instances with no primary key value set. If this method returns something else than None, then the returned value is used when saving the new instance.",
    "locator": {
      "line": 788
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_pk_value_on_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 796,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 787,
    "symbol": "Field.get_pk_value_on_save"
  },
  "id": "64b72797-1db4-4286-8461-779c938e4df2",
  "items": [
    {
      "locator": {
        "line": 788
      },
      "text": "Hook to generate new PK values on save. This method is called when saving instances with no primary key value set. If this method returns something else than None, then the returned value is used when saving the new instance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0018200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 787,
        "selector": "L787-L796",
        "symbol": "Field.get_pk_value_on_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8603cb62-bb5f-492f-917a-83eb28c6785b",
  "subject_name": "django/db/models/fields/__init__::Field.get_pk_value_on_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_pk_value_on_save(self, instance)"
}
```
