# Fact 5e3095da

Store id: 73bcce6e-c70b-4197-8d7b-99a36fbd1a46

## Text

```text
class FetchOne(FetchMode)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.8117440+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "class",
  "parent": "fetch_modes",
  "start_line": 13,
  "symbol": "FetchOne"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":13,"selector":"L13-L20","symbol":"FetchOne"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchOne](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "class",
    "parent": "fetch_modes",
    "start_line": 13,
    "symbol": "FetchOne"
  },
  "id": "73bcce6e-c70b-4197-8d7b-99a36fbd1a46",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.8117440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 13,
        "selector": "L13-L20",
        "symbol": "FetchOne"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "c8ada374-bc1a-40fb-80d2-0389e3f30118",
  "subject_name": "django/db/models/fetch_modes::FetchOne",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchOne(FetchMode)"
}
```
