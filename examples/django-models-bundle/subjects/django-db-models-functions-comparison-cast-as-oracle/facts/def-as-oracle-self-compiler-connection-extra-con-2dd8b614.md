# Fact 2dd8b614

Store id: eb01f6df-4334-4f33-998a-ca432da538d5

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
- posted_at: `2026-11-09T23:44:53.1307800+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 60,
  "symbol": "Cast.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":60,"selector":"L60-L67","symbol":"Cast.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 60,
    "symbol": "Cast.as_oracle"
  },
  "id": "eb01f6df-4334-4f33-998a-ca432da538d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1307800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 60,
        "selector": "L60-L67",
        "symbol": "Cast.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "d13e2366-e51c-4f92-aec2-c665c7ef4e29",
  "subject_name": "django/db/models/functions/comparison::Cast.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
