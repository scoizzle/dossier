# Fact 196e2034

Store id: 5ceb8fc3-c4d7-4a48-950c-1da746642ab4

## Text

```text
class FetchMode
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
- posted_at: `2026-11-09T23:44:49.8017710+00:00`

## Data

```json
{
  "end_line": 10,
  "entity_kind": "class",
  "parent": "fetch_modes",
  "start_line": 4,
  "symbol": "FetchMode"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":4,"selector":"L4-L10","symbol":"FetchMode"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchMode](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 10,
    "entity_kind": "class",
    "parent": "fetch_modes",
    "start_line": 4,
    "symbol": "FetchMode"
  },
  "id": "5ceb8fc3-c4d7-4a48-950c-1da746642ab4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.8017710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 4,
        "selector": "L4-L10",
        "symbol": "FetchMode"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "d2100cbc-785e-48b9-b460-0ab83309219b",
  "subject_name": "django/db/models/fetch_modes::FetchMode",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchMode"
}
```
