# Fact fae4042a

Store id: 0d0d2f69-0f38-4348-a433-4087d357cd1d

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:53.1514120+00:00`

## Data

```json
{
  "end_line": 101,
  "entity_kind": "method",
  "parent": "Coalesce",
  "start_line": 88,
  "symbol": "Coalesce.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L101","symbol":"Coalesce.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Coalesce.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 101,
    "entity_kind": "method",
    "parent": "Coalesce",
    "start_line": 88,
    "symbol": "Coalesce.as_oracle"
  },
  "id": "0d0d2f69-0f38-4348-a433-4087d357cd1d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1514120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L101",
        "symbol": "Coalesce.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "31a29645-ffa5-4a30-b529-f3af3a3eb0c4",
  "subject_name": "django/db/models/functions/comparison::Coalesce.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
