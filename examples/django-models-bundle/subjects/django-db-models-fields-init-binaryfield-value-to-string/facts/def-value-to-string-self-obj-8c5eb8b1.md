# Fact 8c5eb8b1

Store id: 88f9bb9f-4f25-4a2e-b499-05f4b42290f7

## Text

```text
def value_to_string(self, obj)
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
- posted_at: `2026-11-09T22:39:42.7032730+00:00`

## Data

```json
{
  "end_line": 2802,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2800,
  "symbol": "BinaryField.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2800,"selector":"L2800-L2802","symbol":"BinaryField.value_to_string"}`

## Items

```json
[
  {
    "text": "Binary data is serialized as base64",
    "locator": {
      "line": 2801
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2802,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2800,
    "symbol": "BinaryField.value_to_string"
  },
  "id": "88f9bb9f-4f25-4a2e-b499-05f4b42290f7",
  "items": [
    {
      "locator": {
        "line": 2801
      },
      "text": "Binary data is serialized as base64"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7032730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2800,
        "selector": "L2800-L2802",
        "symbol": "BinaryField.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b516339f-e796-4032-beb7-7b42731dbbce",
  "subject_name": "django/db/models/fields/__init__::BinaryField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
