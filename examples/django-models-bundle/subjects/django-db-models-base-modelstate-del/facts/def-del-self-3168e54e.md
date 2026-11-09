# Fact 3168e54e

Store id: aba41806-c3aa-4f02-914d-23ab594c7663

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
- posted_at: `2026-11-09T23:31:53.7310480+00:00`

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
  "id": "aba41806-c3aa-4f02-914d-23ab594c7663",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7310480+00:00"
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
  "subject_id": "4d54bc21-d84e-40c6-b7ab-243a50dc84ba",
  "subject_name": "django/db/models/base::ModelState.__del__",
  "tags": [
    "entity:method"
  ],
  "text": "def __del__(self)"
}
```
