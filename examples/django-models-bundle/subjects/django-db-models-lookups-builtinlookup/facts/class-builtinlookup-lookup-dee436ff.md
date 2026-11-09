# Fact dee436ff

Store id: dc5847de-28ae-4249-a0ca-f012a953a17a

## Text

```text
class BuiltinLookup(Lookup)
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
- posted_at: `2026-11-09T23:32:03.2095960+00:00`

## Data

```json
{
  "end_line": 251,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 234,
  "symbol": "BuiltinLookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":234,"selector":"L234-L251","symbol":"BuiltinLookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::BuiltinLookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 251,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 234,
    "symbol": "BuiltinLookup"
  },
  "id": "dc5847de-28ae-4249-a0ca-f012a953a17a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2095960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 234,
        "selector": "L234-L251",
        "symbol": "BuiltinLookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "60ecaf8e-1e62-46ff-9273-77e602e18552",
  "subject_name": "django/db/models/lookups::BuiltinLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class BuiltinLookup(Lookup)"
}
```
