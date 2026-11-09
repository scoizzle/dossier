# Fact f3d1fc39

Store id: 71b390ee-4342-4080-b4c0-ab022b0509d2

## Text

```text
def get_prep_lookup(self)
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
- posted_at: `2026-11-09T23:44:50.9779600+00:00`

## Data

```json
{
  "end_line": 280,
  "entity_kind": "method",
  "parent": "HasKeys",
  "start_line": 279,
  "symbol": "HasKeys.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":279,"selector":"L279-L280","symbol":"HasKeys.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeys.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 280,
    "entity_kind": "method",
    "parent": "HasKeys",
    "start_line": 279,
    "symbol": "HasKeys.get_prep_lookup"
  },
  "id": "71b390ee-4342-4080-b4c0-ab022b0509d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9779600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 279,
        "selector": "L279-L280",
        "symbol": "HasKeys.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "460f1ea1-eaa1-496e-a39c-438a30000b4a",
  "subject_name": "django/db/models/fields/json::HasKeys.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
