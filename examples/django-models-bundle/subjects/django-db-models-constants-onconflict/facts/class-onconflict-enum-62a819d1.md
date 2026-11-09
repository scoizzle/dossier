# Fact 62a819d1

Store id: 37ab8edd-9e48-42cb-b97e-02b3084f83e8

## Text

```text
class OnConflict(Enum)
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
- posted_at: `2026-11-09T22:39:40.5026420+00:00`

## Data

```json
{
  "end_line": 13,
  "entity_kind": "class",
  "parent": "constants",
  "start_line": 11,
  "symbol": "OnConflict"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constants.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":11,"selector":"L11-L13","symbol":"OnConflict"}`

## Referenced by

None.

## Subject

[django/db/models/constants::OnConflict](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 13,
    "entity_kind": "class",
    "parent": "constants",
    "start_line": 11,
    "symbol": "OnConflict"
  },
  "id": "37ab8edd-9e48-42cb-b97e-02b3084f83e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.5026420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 11,
        "selector": "L11-L13",
        "symbol": "OnConflict"
      },
      "rel": "derived_from",
      "target": "django/db/models/constants.py"
    }
  ],
  "status": "live",
  "subject_id": "5c6f9db6-d889-4d97-bccb-5bcf6aac26e9",
  "subject_name": "django/db/models/constants::OnConflict",
  "tags": [
    "entity:class"
  ],
  "text": "class OnConflict(Enum)"
}
```
