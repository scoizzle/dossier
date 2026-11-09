# Fact 6523717c

Store id: f53df174-8b0e-4630-842c-8509efd45cbf

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T23:44:50.0698850+00:00`

## Data

```json
{
  "end_line": 1340,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1338,
  "symbol": "CharField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1338,"selector":"L1338-L1340","symbol":"CharField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1340,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1338,
    "symbol": "CharField.get_prep_value"
  },
  "id": "f53df174-8b0e-4630-842c-8509efd45cbf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0698850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1338,
        "selector": "L1338-L1340",
        "symbol": "CharField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "95a9c3ba-0644-40bc-8a5e-8787fb8041b3",
  "subject_name": "django/db/models/fields/__init__::CharField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
