# Fact 653f80a0

Store id: 4eba81c4-a140-485a-8b35-00eb8b34995f

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
- posted_at: `2026-11-09T23:31:55.9470540+00:00`

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
  "id": "4eba81c4-a140-485a-8b35-00eb8b34995f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9470540+00:00"
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
  "subject_id": "72aa51ae-3fd8-4627-b52e-d4f75d7166d9",
  "subject_name": "django/db/models/expressions::When.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
