# Fact f3d1fc39

Store id: 53b19bb4-c1ec-4cbd-977c-4cc49387c287

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
- posted_at: `2026-11-09T22:39:43.6583140+00:00`

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
  "id": "53b19bb4-c1ec-4cbd-977c-4cc49387c287",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6583140+00:00"
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
  "subject_id": "831ade8c-8ddc-440d-922d-e64b796a4839",
  "subject_name": "django/db/models/fields/json::HasKeys.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
