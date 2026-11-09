# Fact 797d2afa

Store id: 71ed4107-6156-47fb-a56e-c34f823dcc6d

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
- posted_at: `2026-11-09T23:44:51.6383670+00:00`

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
  "id": "71ed4107-6156-47fb-a56e-c34f823dcc6d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6383670+00:00"
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
  "subject_id": "3f1b5c88-c250-40a2-9530-3debbbe1e34a",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_relationship_model",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_relationship_model(self, from_model=None, **kwargs)"
}
```
