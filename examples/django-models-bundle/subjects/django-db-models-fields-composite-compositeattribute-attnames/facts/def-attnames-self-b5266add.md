# Fact b5266add

Store id: 4205de84-5056-4327-aac9-995a9fa5db67

## Text

```text
def attnames(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.1114420+00:00`

## Data

```json
{
  "end_line": 29,
  "entity_kind": "method",
  "parent": "CompositeAttribute",
  "start_line": 27,
  "symbol": "CompositeAttribute.attnames"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L29","symbol":"CompositeAttribute.attnames"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositeAttribute.attnames](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 29,
    "entity_kind": "method",
    "parent": "CompositeAttribute",
    "start_line": 27,
    "symbol": "CompositeAttribute.attnames"
  },
  "id": "4205de84-5056-4327-aac9-995a9fa5db67",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1114420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L29",
        "symbol": "CompositeAttribute.attnames"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "201441c4-9223-4ba5-bbc4-57f9d7fefd82",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute.attnames",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def attnames(self)"
}
```
