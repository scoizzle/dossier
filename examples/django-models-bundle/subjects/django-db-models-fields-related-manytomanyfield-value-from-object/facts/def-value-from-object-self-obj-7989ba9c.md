# Fact 7989ba9c

Store id: 715d8570-c993-45a3-ae26-68cbddaa5994

## Text

```text
def value_from_object(self, obj)
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
- posted_at: `2026-11-09T23:31:58.8935970+00:00`

## Data

```json
{
  "end_line": 2183,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2182,
  "symbol": "ManyToManyField.value_from_object"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2182,"selector":"L2182-L2183","symbol":"ManyToManyField.value_from_object"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.value_from_object](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2183,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2182,
    "symbol": "ManyToManyField.value_from_object"
  },
  "id": "715d8570-c993-45a3-ae26-68cbddaa5994",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8935970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2182,
        "selector": "L2182-L2183",
        "symbol": "ManyToManyField.value_from_object"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "215ee99a-c4ff-45c9-af8d-8a600778b8ec",
  "subject_name": "django/db/models/fields/related::ManyToManyField.value_from_object",
  "tags": [
    "entity:method"
  ],
  "text": "def value_from_object(self, obj)"
}
```
