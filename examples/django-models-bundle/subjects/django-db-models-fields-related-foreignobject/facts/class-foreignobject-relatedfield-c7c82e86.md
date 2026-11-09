# Fact c7c82e86

Store id: a090a5cc-24d9-4993-8226-0972ec880702

## Text

```text
class ForeignObject(RelatedField)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.3051050+00:00`

## Data

```json
{
  "end_line": 958,
  "entity_kind": "class",
  "parent": "related",
  "start_line": 544,
  "symbol": "ForeignObject"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":544,"selector":"L544-L958","symbol":"ForeignObject"}`

## Items

```json
[
  {
    "text": "Abstraction of the ForeignKey relation to support multi-column relations.",
    "locator": {
      "line": 545
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 958,
    "entity_kind": "class",
    "parent": "related",
    "start_line": 544,
    "symbol": "ForeignObject"
  },
  "id": "a090a5cc-24d9-4993-8226-0972ec880702",
  "items": [
    {
      "locator": {
        "line": 545
      },
      "text": "Abstraction of the ForeignKey relation to support multi-column relations."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3051050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 544,
        "selector": "L544-L958",
        "symbol": "ForeignObject"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "8a37ca3a-8a42-482e-b072-2a94df7d9a72",
  "subject_name": "django/db/models/fields/related::ForeignObject",
  "tags": [
    "entity:class"
  ],
  "text": "class ForeignObject(RelatedField)"
}
```
