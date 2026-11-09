# Fact 3eed902f

Store id: 5029c903-6b67-4afa-8f9d-93a864efe0e4

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
- posted_at: `2026-11-09T23:44:54.0894040+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "method",
  "parent": "Left",
  "start_line": 172,
  "symbol": "Left.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":172,"selector":"L172-L173","symbol":"Left.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Left.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "method",
    "parent": "Left",
    "start_line": 172,
    "symbol": "Left.as_oracle"
  },
  "id": "5029c903-6b67-4afa-8f9d-93a864efe0e4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0894040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 172,
        "selector": "L172-L173",
        "symbol": "Left.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "c48919f4-501b-481d-8fbf-410df754505d",
  "subject_name": "django/db/models/functions/text::Left.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
