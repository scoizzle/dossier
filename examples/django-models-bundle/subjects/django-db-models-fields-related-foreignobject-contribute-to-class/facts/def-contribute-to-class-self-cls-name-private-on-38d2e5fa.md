# Fact 38d2e5fa

Store id: e071c11b-1ea1-4755-b0ca-4fcae49e47c4

## Text

```text
def contribute_to_class(self, cls, name, private_only=False, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.3632240+00:00`

## Data

```json
{
  "end_line": 941,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 939,
  "symbol": "ForeignObject.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":939,"selector":"L939-L941","symbol":"ForeignObject.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 941,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 939,
    "symbol": "ForeignObject.contribute_to_class"
  },
  "id": "e071c11b-1ea1-4755-b0ca-4fcae49e47c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3632240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 939,
        "selector": "L939-L941",
        "symbol": "ForeignObject.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "5b2aec41-2c22-4576-b2c1-cf3d1478da53",
  "subject_name": "django/db/models/fields/related::ForeignObject.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name, private_only=False, **kwargs)"
}
```
