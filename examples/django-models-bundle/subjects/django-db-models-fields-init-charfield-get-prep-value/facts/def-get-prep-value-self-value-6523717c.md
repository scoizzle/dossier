# Fact 6523717c

Store id: 2aa7b3e1-6c17-42f8-8be6-01a8bad33b41

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
- posted_at: `2026-11-09T22:39:42.3878140+00:00`

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
  "id": "2aa7b3e1-6c17-42f8-8be6-01a8bad33b41",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3878140+00:00"
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
  "subject_id": "ca0a3624-1017-4f66-ba27-ada797bc9f64",
  "subject_name": "django/db/models/fields/__init__::CharField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
