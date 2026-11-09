# Fact 99fa355e

Store id: 4d2081e7-6425-47a3-baa5-b71b48bf155b

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
- posted_at: `2026-11-09T23:31:56.4619030+00:00`

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
  "id": "4d2081e7-6425-47a3-baa5-b71b48bf155b",
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
    "posted_at": "2026-11-09T23:31:56.4619030+00:00"
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
  "subject_id": "28716e52-c800-43d4-bf88-077cdece2b2e",
  "subject_name": "django/db/models/fields/__init__::Field.get_pk_value_on_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_pk_value_on_save(self, instance)"
}
```
