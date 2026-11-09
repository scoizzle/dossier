# Fact 9ad25024

Store id: 27c19631-7938-4246-bbd4-444bb99e79f5

## Text

```text
def get_reverse_path_info(self, filtered_relation=None)
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
- posted_at: `2026-11-09T23:44:51.5541540+00:00`

## Data

```json
{
  "end_line": 925,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 911,
  "symbol": "ForeignObject.get_reverse_path_info"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":911,"selector":"L911-L925","symbol":"ForeignObject.get_reverse_path_info"}`

## Items

```json
[
  {
    "text": "Get path from the related model to this field's model.",
    "locator": {
      "line": 912
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_reverse_path_info](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 925,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 911,
    "symbol": "ForeignObject.get_reverse_path_info"
  },
  "id": "27c19631-7938-4246-bbd4-444bb99e79f5",
  "items": [
    {
      "locator": {
        "line": 912
      },
      "text": "Get path from the related model to this field's model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5541540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 911,
        "selector": "L911-L925",
        "symbol": "ForeignObject.get_reverse_path_info"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "5136b5f4-e9de-4b5a-8e31-7441b1356ef5",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_reverse_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_reverse_path_info(self, filtered_relation=None)"
}
```
