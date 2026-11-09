# Fact 5e3095da

Store id: d6009e14-c187-4d79-b873-fc516f56e6d5

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
- posted_at: `2026-11-09T22:39:41.9923560+00:00`

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
  "id": "d6009e14-c187-4d79-b873-fc516f56e6d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.9923560+00:00"
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
  "subject_id": "6b7685c8-f42b-4f63-b9d8-ce96a11711ae",
  "subject_name": "django/db/models/fetch_modes::FetchOne",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchOne(FetchMode)"
}
```
