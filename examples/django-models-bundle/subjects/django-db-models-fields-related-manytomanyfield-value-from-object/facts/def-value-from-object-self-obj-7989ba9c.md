# Fact 7989ba9c

Store id: 04cf0546-a3fd-40b7-88bf-7b018b9ba849

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
- posted_at: `2026-11-09T23:44:51.6725010+00:00`

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
  "id": "04cf0546-a3fd-40b7-88bf-7b018b9ba849",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6725010+00:00"
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
  "subject_id": "4af806fa-c4ba-4de6-9335-ffbd8d33aa71",
  "subject_name": "django/db/models/fields/related::ManyToManyField.value_from_object",
  "tags": [
    "entity:method"
  ],
  "text": "def value_from_object(self, obj)"
}
```
