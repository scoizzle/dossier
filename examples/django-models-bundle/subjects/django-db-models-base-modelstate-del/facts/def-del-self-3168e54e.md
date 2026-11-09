# Fact 3168e54e

Store id: fcd82484-5556-4bdb-9065-a986b71d4ab1

## Text

```text
def __del__(self)
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
- posted_at: `2026-11-09T22:39:40.3305880+00:00`

## Data

```json
{
  "end_line": 498,
  "entity_kind": "method",
  "parent": "ModelState",
  "start_line": 497,
  "symbol": "ModelState.__del__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":497,"selector":"L497-L498","symbol":"ModelState.__del__"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelState.__del__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 498,
    "entity_kind": "method",
    "parent": "ModelState",
    "start_line": 497,
    "symbol": "ModelState.__del__"
  },
  "id": "fcd82484-5556-4bdb-9065-a986b71d4ab1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3305880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 497,
        "selector": "L497-L498",
        "symbol": "ModelState.__del__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "5973a882-2a3e-4fa5-ad78-3f0a61122d63",
  "subject_name": "django/db/models/base::ModelState.__del__",
  "tags": [
    "entity:method"
  ],
  "text": "def __del__(self)"
}
```
