# Fact fe8b901b

Store id: 2fcadab4-6b9a-42be-8417-dd437e59deab

## Text

```text
def validators(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.3119630+00:00`

## Data

```json
{
  "end_line": 820,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 814,
  "symbol": "Field.validators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":814,"selector":"L814-L820","symbol":"Field.validators"}`

## Items

```json
[
  {
    "text": "Some validators can't be created at field initialization time. This method provides a way to delay their creation until required.",
    "locator": {
      "line": 816
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.validators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 820,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 814,
    "symbol": "Field.validators"
  },
  "id": "2fcadab4-6b9a-42be-8417-dd437e59deab",
  "items": [
    {
      "locator": {
        "line": 816
      },
      "text": "Some validators can't be created at field initialization time. This method provides a way to delay their creation until required."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3119630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 814,
        "selector": "L814-L820",
        "symbol": "Field.validators"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e19d5ad3-85da-4067-975e-41cf52e71a6b",
  "subject_name": "django/db/models/fields/__init__::Field.validators",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def validators(self)"
}
```
