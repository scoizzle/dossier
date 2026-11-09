# Fact 41793d8c

Store id: 4560e86e-a390-4d29-9239-02f2e07abf96

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
- posted_at: `2026-11-09T23:44:53.3770110+00:00`

## Data

```json
{
  "end_line": 241,
  "entity_kind": "method",
  "parent": "Now",
  "start_line": 238,
  "symbol": "Now.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":238,"selector":"L238-L241","symbol":"Now.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Now.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 241,
    "entity_kind": "method",
    "parent": "Now",
    "start_line": 238,
    "symbol": "Now.as_oracle"
  },
  "id": "4560e86e-a390-4d29-9239-02f2e07abf96",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3770110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 238,
        "selector": "L238-L241",
        "symbol": "Now.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "a682eb32-c5d2-48a4-994f-19de9d745c51",
  "subject_name": "django/db/models/functions/datetime::Now.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
