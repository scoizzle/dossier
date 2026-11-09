# Fact 797d2afa

Store id: 1aa22c7e-8101-4d3d-9915-281484a9bff1

## Text

```text
def _check_relationship_model(self, from_model=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.4545910+00:00`

## Data

```json
{
  "end_line": 1851,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1598,
  "symbol": "ManyToManyField._check_relationship_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1598,"selector":"L1598-L1851","symbol":"ManyToManyField._check_relationship_model"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_relationship_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1851,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1598,
    "symbol": "ManyToManyField._check_relationship_model"
  },
  "id": "1aa22c7e-8101-4d3d-9915-281484a9bff1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4545910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1598,
        "selector": "L1598-L1851",
        "symbol": "ManyToManyField._check_relationship_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "be9f7762-d976-4711-a720-3e7f1da736b3",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_relationship_model",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_relationship_model(self, from_model=None, **kwargs)"
}
```
