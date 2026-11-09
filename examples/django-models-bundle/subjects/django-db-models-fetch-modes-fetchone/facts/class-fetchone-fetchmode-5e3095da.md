# Fact 5e3095da

Store id: b865c4a7-6d55-4cfe-9835-b9d65c46f2ea

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
- posted_at: `2026-11-09T23:31:56.2159010+00:00`

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
  "id": "b865c4a7-6d55-4cfe-9835-b9d65c46f2ea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2159010+00:00"
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
  "subject_id": "b110837e-8b78-4eb2-b7f7-241bc738dd03",
  "subject_name": "django/db/models/fetch_modes::FetchOne",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchOne(FetchMode)"
}
```
