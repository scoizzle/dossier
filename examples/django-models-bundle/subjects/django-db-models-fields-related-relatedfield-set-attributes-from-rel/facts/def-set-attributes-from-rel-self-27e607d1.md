# Fact 27e607d1

Store id: 1c50a7c3-53dd-4787-b419-7ba1ae254772

## Text

```text
def set_attributes_from_rel(self)
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
- posted_at: `2026-11-09T23:31:58.6329320+00:00`

## Data

```json
{
  "end_line": 475,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 467,
  "symbol": "RelatedField.set_attributes_from_rel"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":467,"selector":"L467-L475","symbol":"RelatedField.set_attributes_from_rel"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.set_attributes_from_rel](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 475,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 467,
    "symbol": "RelatedField.set_attributes_from_rel"
  },
  "id": "1c50a7c3-53dd-4787-b419-7ba1ae254772",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6329320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 467,
        "selector": "L467-L475",
        "symbol": "RelatedField.set_attributes_from_rel"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "bb68c993-5eb1-44c8-bbf0-4142d80b79b8",
  "subject_name": "django/db/models/fields/related::RelatedField.set_attributes_from_rel",
  "tags": [
    "entity:method"
  ],
  "text": "def set_attributes_from_rel(self)"
}
```
