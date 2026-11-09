# Fact 08c90e1a

Store id: 30da2505-2f4c-4891-9fce-a6b3a35e1ac2

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T23:44:51.5770070+00:00`

## Data

```json
{
  "end_line": 1209,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1208,
  "symbol": "ForeignKey.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1208,"selector":"L1208-L1209","symbol":"ForeignKey.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1209,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1208,
    "symbol": "ForeignKey.to_python"
  },
  "id": "30da2505-2f4c-4891-9fce-a6b3a35e1ac2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5770070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1208,
        "selector": "L1208-L1209",
        "symbol": "ForeignKey.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "88eaf599-6335-45f6-a1d2-7b2b00c6dba4",
  "subject_name": "django/db/models/fields/related::ForeignKey.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
