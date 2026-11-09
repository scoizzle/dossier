# Fact 653f80a0

Store id: aeaada03-ad42-4eb2-b650-0a25d0592242

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:44:49.6100000+00:00`

## Data

```json
{
  "end_line": 1662,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1661,
  "symbol": "When.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1661,"selector":"L1661-L1662","symbol":"When.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1662,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1661,
    "symbol": "When.__str__"
  },
  "id": "aeaada03-ad42-4eb2-b650-0a25d0592242",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6100000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1661,
        "selector": "L1661-L1662",
        "symbol": "When.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3fbee853-3cb4-4039-9f7e-83ff3d7f62b6",
  "subject_name": "django/db/models/expressions::When.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
