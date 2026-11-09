# Fact 653f80a0

Store id: 854f6bd3-511f-4039-a368-3ac851608e48

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
- posted_at: `2026-11-09T22:39:41.6908330+00:00`

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
  "id": "854f6bd3-511f-4039-a368-3ac851608e48",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6908330+00:00"
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
  "subject_id": "053ad366-6b88-42ec-b8c3-016a634fc07d",
  "subject_name": "django/db/models/expressions::When.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
