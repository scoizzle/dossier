# Fact a0d8b6e7

Store id: 36d5b8d1-58d5-4ab9-917f-8f559035160c

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
- posted_at: `2026-11-09T22:39:48.1520210+00:00`

## Data

```json
{
  "end_line": 520,
  "entity_kind": "method",
  "parent": "In",
  "start_line": 506,
  "symbol": "In.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":506,"selector":"L506-L520","symbol":"In.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::In.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 520,
    "entity_kind": "method",
    "parent": "In",
    "start_line": 506,
    "symbol": "In.get_prep_lookup"
  },
  "id": "36d5b8d1-58d5-4ab9-917f-8f559035160c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1520210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 506,
        "selector": "L506-L520",
        "symbol": "In.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c766c43b-9f7b-4d27-82c9-fcc9df4f0af5",
  "subject_name": "django/db/models/lookups::In.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
