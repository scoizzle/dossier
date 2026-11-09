# Fact 08ac7323

Store id: caeae394-7bdd-4042-8931-d091ae78aee1

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:32:03.1274240+00:00`

## Data

```json
{
  "end_line": 59,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 58,
  "symbol": "Lookup.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":58,"selector":"L58-L59","symbol":"Lookup.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 59,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 58,
    "symbol": "Lookup.__repr__"
  },
  "id": "caeae394-7bdd-4042-8931-d091ae78aee1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1274240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 58,
        "selector": "L58-L59",
        "symbol": "Lookup.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "1a8e4a3a-ab05-4e70-92ca-600c88b14890",
  "subject_name": "django/db/models/lookups::Lookup.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
