# Fact f55533cb

Store id: 546a23e7-0bec-43c7-ad15-9a07332dafcb

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
- posted_at: `2026-11-09T22:39:41.7653460+00:00`

## Data

```json
{
  "end_line": 2113,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2107,
  "symbol": "Window.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2107,"selector":"L2107-L2113","symbol":"Window.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2113,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2107,
    "symbol": "Window.__str__"
  },
  "id": "546a23e7-0bec-43c7-ad15-9a07332dafcb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7653460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2107,
        "selector": "L2107-L2113",
        "symbol": "Window.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c9bdd0de-b3a0-4fe6-a744-86bda3f7c4b3",
  "subject_name": "django/db/models/expressions::Window.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
