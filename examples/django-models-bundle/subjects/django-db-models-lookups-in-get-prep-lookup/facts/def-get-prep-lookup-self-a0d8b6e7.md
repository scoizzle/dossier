# Fact a0d8b6e7

Store id: 35f6f301-93af-47fb-b5e1-acd78faadcb7

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
- posted_at: `2026-11-09T23:32:03.3226820+00:00`

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
  "id": "35f6f301-93af-47fb-b5e1-acd78faadcb7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3226820+00:00"
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
  "subject_id": "706aa208-41cf-4f40-acef-519fee3b7fbd",
  "subject_name": "django/db/models/lookups::In.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
