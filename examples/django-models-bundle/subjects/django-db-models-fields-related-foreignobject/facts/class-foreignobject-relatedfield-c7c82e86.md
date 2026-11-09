# Fact c7c82e86

Store id: 755311ed-7c6c-4f6b-99ea-e01c92ddba3a

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
- posted_at: `2026-11-09T23:44:51.5111210+00:00`

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
  "id": "755311ed-7c6c-4f6b-99ea-e01c92ddba3a",
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
    "posted_at": "2026-11-09T23:44:51.5111210+00:00"
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
  "subject_id": "a4891144-0778-4880-a3df-af6cdf1ecd8d",
  "subject_name": "django/db/models/fields/related::ForeignObject",
  "tags": [
    "entity:class"
  ],
  "text": "class ForeignObject(RelatedField)"
}
```
