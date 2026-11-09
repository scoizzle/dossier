# Fact 8d395106

Store id: e31b3d77-a87f-4338-aae2-4d4da73a81ec

## Text

```text
class TruncYear(TruncBase)
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
- posted_at: `2026-11-09T23:32:01.2722130+00:00`

## Data

```json
{
  "end_line": 362,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 361,
  "symbol": "TruncYear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":361,"selector":"L361-L362","symbol":"TruncYear"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncYear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 362,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 361,
    "symbol": "TruncYear"
  },
  "id": "e31b3d77-a87f-4338-aae2-4d4da73a81ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2722130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 361,
        "selector": "L361-L362",
        "symbol": "TruncYear"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "d8aabd1f-2de6-4cdb-a2be-11bc7e9ed90c",
  "subject_name": "django/db/models/functions/datetime::TruncYear",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncYear(TruncBase)"
}
```
